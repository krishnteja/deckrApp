import { Component, OnInit } from '@angular/core';
import { UserSettings } from 'src/app/shared/types/user-settings';
import { Fixtures } from 'src/app/shared/data/fixtures';
import { User } from 'src/app/shared/types/user.interface';

@Component({
  selector: 'app-user-views',
  templateUrl: './user-views.component.html',
  styleUrls: ['./user-views.component.scss']
})
export class UserViewsComponent implements OnInit {
	private userSettings: UserSettings[] = [];
	private allUsers: User[] = [] 

	constructor() { 
		this.userSettings = Fixtures.userSettings;
		this.allUsers = Fixtures.users;
	}

	ngOnInit() {
	}

}
