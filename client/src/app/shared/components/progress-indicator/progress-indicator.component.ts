import { Component, OnInit, Input, OnChanges, SimpleChanges, SimpleChange } from '@angular/core';

@Component({
  selector: 'app-progress-indicator',
  templateUrl: './progress-indicator.component.html',
  styleUrls: ['./progress-indicator.component.scss']
})
export class ProgressIndicatorComponent implements OnInit, OnChanges {
	@Input() complete: number;
	@Input() total: number;
	view: any[] = [200, 200];
	data: any;
	colorScheme = {
		domain: ['#5AA454', '#A10A28', '#C7B42C']
	};

	constructor() { }

	ngOnInit() {
		this.data = [{
			name: "",
			value: this.complete / this.total * 100
		}];
	}

	ngOnChanges(changes: SimpleChanges) {
		if (changes.complete && changes.total) {
			this.data = [{
				name: "",
				value: changes.complete.currentValue / changes.total.currentValue * 100
			}];
		} else if (changes.complete) {
			this.data = [{
				name: "",
				value: changes.complete.currentValue / this.total * 100
			}];
		} else if (changes.total) {
			this.data = [{
				name: "",
				value: this.complete / changes.total.currentValue * 100
			}];
		}
	}	
}
