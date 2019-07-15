import { Injectable } from '@angular/core';
import { User } from '../../shared/types/user.interface';
import { BehaviorSubject } from 'rxjs';
import { Fixtures } from 'src/app/shared/data/fixtures';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
	private loggedInUser: User;
	loggedInUserChanged: BehaviorSubject<User> = new BehaviorSubject(null);
	private isAuth: boolean = false;
	isAuthChanged: BehaviorSubject<boolean> = new BehaviorSubject(false);
	private isAdmin: boolean = false;
	isAdminChanged: BehaviorSubject<boolean> = new BehaviorSubject(false);

  	constructor(
		  private router: Router
	  ) { 
		this.loggedInUserChanged.subscribe((user: User) => {
			this.loggedInUser = user;
			console.log(user);
			if (user && user !== null){
				this.isAuthChanged.next(true);
			} else {
				this.isAuthChanged.next(false);
				this.isAdminChanged.next(false);
			}	
			this.isAdminChanged.next(this.getIsAdmin());
		});
		this.isAuthChanged.subscribe( (newIsAuth: boolean) => {
			this.isAuth = newIsAuth;
		});
		this.isAdminChanged.subscribe( (newIsAdmin: boolean) => {
			this.isAdmin = newIsAdmin;
		});

		// this.loggedInUserChanged.next(Fixtures.user);
	}

	loginAdmin() {
		this.loggedInUserChanged.next(Fixtures.adminUser);
		this.router.navigate(["/admin"]);
	}

	loginUser() {
		this.loggedInUserChanged.next(Fixtures.user);
		this.router.navigate(["home"]);
	}

	getIsAdmin(): boolean {
		if (!this.loggedInUser || this.loggedInUser === null) {
			return false;
		}
		return this.loggedInUser.isAdmin === true;
	}

	logout() {
		this.loggedInUserChanged.next(null);
		this.router.navigate([""]);
	}
}
