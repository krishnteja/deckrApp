import { Injectable } from '@angular/core';
import {
  CanActivate,
  ActivatedRouteSnapshot,
  RouterStateSnapshot,
  CanLoad,
  Route,
  Router
} from '@angular/router';
import { AuthService } from './auth.service';

@Injectable()
export class AuthUserGuard implements CanActivate, CanLoad {
	canLoadUser: boolean = false; 

	constructor(
		private authService: AuthService,
		private router: Router
	) {
		this.authService.isAuthChanged.subscribe((isAuth: boolean) => {
			this.canLoadUser = isAuth;
		});
	}

	canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
		if (this.canLoadUser === false) {
			this.router.navigateByUrl('/login');
		}
		return this.canLoadUser
	}

	canLoad(route: Route) {
		if (this.canLoadUser === false) {
			this.router.navigateByUrl('/login');
		}
		return this.canLoadUser;
	}
}  
