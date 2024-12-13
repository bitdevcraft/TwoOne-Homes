import {Component, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Button} from "primeng/button";
import {ButtonGroupModule} from "primeng/buttongroup";
import {PrimeTemplate} from "primeng/api";
import {RouterLink} from "@angular/router";
import {TableModule} from "primeng/table";

interface Column {
  field: string;
  header: string;
}

@Component({
  selector: 'app-role',
  standalone: true,
  imports: [
    Button,
    ButtonGroupModule,
    PrimeTemplate,
    RouterLink,
    TableModule
  ],
  templateUrl: './role.component.html',
  styleUrl: './role.component.scss'
})
export class RoleComponent implements OnInit{
  cols!: Column[];

  records!: any[];

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.cols = [
      { field: 'role', header: 'Role' },
    ];

  }

}
