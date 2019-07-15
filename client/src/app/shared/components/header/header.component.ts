import { Component, OnInit, EventEmitter, Output, Input } from '@angular/core';
import { AuthService } from 'src/app/modules/auth/auth.service';
import { User } from '../../types/user.interface';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
	export class HeaderComponent implements OnInit {
	@Output() sidenavToggle = new EventEmitter<void>();
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

	onToggleSidenav() {
		this.sidenavToggle.emit();
	}

	logout() {
		this.authService.logout();
	}
}