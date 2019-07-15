import { Component, OnInit, Input } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-destination-button',
  templateUrl: './destination-button.component.html',
  styleUrls: ['./destination-button.component.scss']
})
export class DestinationButtonComponent implements OnInit {
	@Input() route: string;

	constructor(
		private router: Router,
	) { }

	ngOnInit() {
	}

	navigateToRoute() {
		if(this.route) {
			this.router.navigate([this.route]);		
		}
	}
}
