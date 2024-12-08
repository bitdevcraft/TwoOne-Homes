import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { BehaviorSubject, Observable, map, switchMap } from 'rxjs';
import { IdleUserService } from '../../../utils/services/idle-user.service';

interface userToken {
  username: string;
  token: string;
}

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private isAuthenticated = new BehaviorSubject<boolean>(false);
  isLoggedIn$ = this.isAuthenticated.asObservable();
  private token: string | null = null;
  private tokenSubject: BehaviorSubject<string | null>;

  constructor(
    private http: HttpClient,
    private router: Router,
  ) {
    // Check for a token in local storage on initialization
    this.token = localStorage.getItem('authToken');
    this.tokenSubject = new BehaviorSubject<string | null>(this.token);
    this.isAuthenticated.next(!!this.token); // Set state based on token existence
  }

  login(
    credentials: { username: string; password: string },
    returnUrl: string,
  ) {
    this.http
      .post<userToken>('/api/auth/login', credentials)
      .pipe(
        switchMap((response) => {
          this.setToken(response.token);

          return this.getIpAddress().pipe(
            map((response) => {
              return response;
            }),
          );
        }),
        switchMap((response) => {
          console.log('IP Address', response);
          return this.loginActivity(response, '').pipe((response) => {
            return response;
          });
        }),
      )
      .subscribe((data) => {
        this.router.navigateByUrl(returnUrl);
        console.log('Final', data);
      });
  }

  logout(returnUrl: string = '/') {
    this.clearToken();
    this.router.navigate(['/auth/login'], {
      queryParams: {
        returnUrl: returnUrl === '/auth/login' ? '/' : returnUrl,
      },
    });
  }

  getIpAddress(): Observable<string> {
    return this.http.get<string>('/ipify?format=json').pipe(
      map((response: any) => {
        console.log('Get IP Address', response);
        return response.ip;
      }),
    );
  }

  loginActivity(ipAddress: string, deviceInfo: string): Observable<any> {
    return this.http
      .post('/api/auth/loginActivity', {
        ipAddress: ipAddress,
        deviceInfo: deviceInfo,
      })
      .pipe(
        map((response: any) => {
          return response;
        }),
      );
  }

  refreshAccessToken(): Observable<any> {
    return this.http.post<any>(`/api/auth/refreshToken`, {});
  }

  accessToken() {
    return localStorage.getItem('authToken');
  }

  // Getter to access the token as Observable
  get token$(): Observable<string | null> {
    return this.tokenSubject.asObservable();
  }

  // Set the token and store it in localStorage
  setToken(token: string): void {
    localStorage.setItem('authToken', token); // Save to localStorage
    this.tokenSubject.next(token); // Emit new token to subscribers
    this.isAuthenticated.next(true);
    this.token = token;
  }

  // Clear the token
  clearToken(): void {
    localStorage.removeItem('authToken');
    this.token = null;
    this.tokenSubject.next(null);
    this.isAuthenticated.next(false);
  }
}
