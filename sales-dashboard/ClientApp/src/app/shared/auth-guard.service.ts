import { Injectable } from '@angular/core';
import { CanActivate, Router, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { JwtHelper } from 'angular2-jwt';
import { LoginService } from './login.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuardService implements CanActivate {
  constructor(private router: Router,
    private loginService: LoginService) { }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
    let jwtHelper: JwtHelper = new JwtHelper();
    const currentToken = this.loginService.currentToken;
    if (currentToken && !jwtHelper.isTokenExpired(currentToken)) {
      return true;
    }

    this.loginService.logout();
    this.router.navigate(['login'], { queryParams: { returnUrl: state.url }});
    return false;
  }
}
