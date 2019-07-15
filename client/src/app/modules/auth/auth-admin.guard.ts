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
export class AuthAdminGuard implements CanActivate, CanLoad {
	canLoadAdmin: boolean = false; 

	constructor(
		private authService: AuthService,
		private router: Router
	) {
		this.authService.isAdminChanged.subscribe((isAdmin: boolean) => {
			this.canLoadAdmin = isAdmin;
		});
	}

	canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
		if (this.canLoadAdmin === false) {
			this.router.navigateByUrl('/login');
		}
		return this.canLoadAdmin;
	}

	canLoad(route: Route) {
		if (this.canLoadAdmin === false) {
			this.router.navigateByUrl('/login');
		}
		return this.canLoadAdmin;
	}
}  
