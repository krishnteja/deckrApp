import { Component, OnInit, Output, EventEmitter, Input } from '@angular/core';
import { AuthService } from 'src/app/modules/auth/auth.service';
import { User } from '../../types/user.interface';

@Component({
  selector: 'app-sidenav-list',
  templateUrl: './sidenav-list.component.html',
  styleUrls: ['./sidenav-list.component.scss']
})
export class SidenavListComponent implements OnInit {
	@Output() closeSidenav = new EventEmitter<void>();
	@Input() activeRoute = 'login';
	@Input() isAuth: boolean = false;
	@Input() isAdmin: boolean = false;
	@Input() loggedInUser: User = null;

	constructor(
		private authService: AuthService
	) {

	}

	ngOnInit() {
		this.isAuth = false;
	}

	logout() {
		this.authService.logout();
	}

	close() {
		this.closeSidenav.emit();
	}
}
