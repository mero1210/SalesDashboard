import { Component } from '@angular/core';
import { LoginService } from './shared/login.service';
import { Router, NavigationStart } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';
  showHeader: boolean = true;

  constructor(private loginService: LoginService,
    private router: Router) {
      this.showHeader = this.loginService.isTokenValid;

      this.router.events.forEach((event) => {
      if (event instanceof NavigationStart) {
        this.showHeader = this.loginService.isTokenValid;
      }
    });
  }

  ngOnInit() {
  }
}
