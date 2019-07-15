import { Component, OnInit } from '@angular/core';
import { Fixtures } from 'src/app/shared/data/fixtures';
import { ModuleProgress } from 'src/app/shared/types/module-progress';

@Component({
  selector: 'app-user-progress',
  templateUrl: './user-progress.component.html',
  styleUrls: ['./user-progress.component.scss']
})
export class UserProgressComponent implements OnInit {
	private modules: ModuleProgress[] = Fixtures.moduleProgress;

	constructor() { }

	ngOnInit() {
	}
}
