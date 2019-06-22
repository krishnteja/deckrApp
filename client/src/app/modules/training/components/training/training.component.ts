import { Component, OnInit } from '@angular/core';
import { TrainingService } from '../../training.service';
import { Training } from 'src/app/shared/types/training.class';

@Component({
	selector: 'app-training',
	templateUrl: './training.component.html',
	styleUrls: ['./training.component.scss']
})
export class TrainingComponent implements OnInit {
	private trainings: Training[] = [];
	
  	constructor(
	  	private trainingService: TrainingService
  	) { 
		this.trainingService.trainingsChanged.subscribe( (newTrainings: Training[]) => {
			this.trainings = newTrainings;
		});		
	}

  	ngOnInit() {
  
	}
}
