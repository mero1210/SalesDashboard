import { map } from 'rxjs/operators';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { JwtHelper } from 'angular2-jwt';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(private http: HttpClient) { }

  Login(username: string, password: string) {
    return this.http.post<any>('api/authentication/login', { username, password })
      .pipe(map(response => {
        if (response && response.token) {
          localStorage.setItem('currentUser', response.token);
        }
        return response;
      }));
  }

  get currentToken() {
    const token = localStorage.getItem('currentUser');

    if (!token) {
      return null;
    }
    return token;
  }

  get isTokenValid(): boolean {
    let jwtHelper: JwtHelper = new JwtHelper();
    const token = localStorage.getItem('currentUser');

    if (!token || jwtHelper.isTokenExpired(token)) {
      return false;
    }
    
    return true;
  }

  logout() {
    localStorage.removeItem('currentUser');
  }
}
