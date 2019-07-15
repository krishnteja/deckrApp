import { Component } from '@angular/core';
import { User } from './shared/types/user.interface';
import { AuthService } from './modules/auth/auth.service';
import { Router, NavigationEnd } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  
})
export class AppComponent {
	private activeRoute = 'login';
	private isAuth: boolean = false;
	private isAdmin: boolean = false;
	private loggedInUser: User = null;

	constructor(
		private authService: AuthService,
		private router: Router
	) {
		
		this.authService.loggedInUserChanged.subscribe((loggedInUser: User) => {
			this.loggedInUser = loggedInUser;
		});
		this.authService.isAuthChanged.subscribe((isAuth: boolean) => {
			this.isAuth = isAuth;
		});
		this.authService.isAdminChanged.subscribe((isAdmin: boolean) => {
			this.isAdmin = isAdmin;
		});
		
		router.events.subscribe((val) => {
			if (val instanceof NavigationEnd) {
				this.activeRoute = val.url;
			}
		});
	}	
}
