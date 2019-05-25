import { Component, OnInit } from '@angular/core';
import { LoginService } from '../shared/login.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  username: string;
  password: string;

  constructor(private loginService: LoginService,
    private router: Router) { }

  ngOnInit() {
  }

  login() {
    this.loginService.Login(this.username, this.password)
      .subscribe(result => {
        if (result && result.token) {
          this.router.navigate(['/']);
        }
      }, error => {

      })
  }

}
