import {
  ChangeDetectionStrategy,
  ChangeDetectorRef,
  Component,
  OnDestroy,
  OnInit,
} from '@angular/core';
import { MessageService, PrimeNGConfig } from 'primeng/api';
import {
  ActivatedRoute,
  Router,
  RouterOutlet,
  RouterStateSnapshot,
} from '@angular/router';
import { IdleUserService } from './utils/services/idle-user.service';
import { Keepalive, NgIdleKeepaliveModule } from '@ng-idle/keepalive';
import { IdleExpiry, SimpleExpiry } from '@ng-idle/core';
import { IdleMessages, IdleStatus, IdleUserTimes } from './utils/models';
import { Subscription } from 'rxjs';
import { AuthService } from './crm/components/auth/auth.service';
import { MessageModule } from 'primeng/message';
import { AppToastService } from './layout/service/app.toast.service';
import { ToastModule } from 'primeng/toast';

const SERVICES: any[] = [IdleUserService];

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  standalone: true,
  imports: [RouterOutlet, NgIdleKeepaliveModule, MessageModule, ToastModule],
  changeDetection: ChangeDetectionStrategy.Default,
  providers: [
    // Add Keepalive to providers
    Keepalive,
    {
      provide: IdleExpiry,
      useClass: SimpleExpiry,
    },
    SERVICES,
    MessageService,
  ],
})
export class AppComponent implements OnInit, OnDestroy {
  subscription: Subscription[] = [];
  idleStatus: string = IdleMessages.IDLE_NO_STARTED;

  constructor(
    private primengConfig: PrimeNGConfig,
    private idleUserService: IdleUserService,
    private keepalive: Keepalive,
    private cd: ChangeDetectorRef,
    private authService: AuthService,
    private router: Router,
    private messageService: MessageService,
    private toastService: AppToastService,
  ) {}

  ngOnInit() {
    this.primengConfig.ripple = true;

    this.subscription.push(
      this.idleUserService.idleStatus$.subscribe((status) => {
        // console.log('@@@', status);
        if (status === IdleMessages.IDLE_TIMEOUT) {
          this.authService.logout(this.router.url);
        } else if (status !== IdleMessages.IDLE_STARTED) {
          this.cd.detectChanges();
        }
      }),
    );

    this.subscription.push(
      this.authService.isLoggedIn$.subscribe((status) => {
        if (status) {
          console.log('@@@ User has Logged In');
          this.reset();
        } else {
          this.idleUserService.stopWatching();
        }
      }),
    );

    this.subscription.push(
      this.toastService.message$.subscribe((message) => {
        this.messageService.add(message);
      }),
    );

    this.keepalive.interval(10); //15
  }

  reset() {
    this.idleUserService.setInterrupts();
    this.idleUserService.startWatching();
    this.idleStatus = IdleMessages.IDLE_STARTED;
    this.cd.detectChanges();
    window.localStorage.setItem('loggedIn', 'true');
  }

  ngOnDestroy() {
    this.idleUserService.stopWatching();
    this.subscription.forEach((sub) => sub.unsubscribe());
  }
}
