import { Training } from '../../types/training.interface';
import { TrainingStatus } from '../../types/training-status';

export const trainingsFixture: Training[] = [
	{
		id: 1,
		name: 'Training 1',
		dueDate: new Date(),
		timeToComplete: 2,
		progress: 0,
		description: 'This is an exemple training. It is really awesome.',
		status: TrainingStatus.notStarted
	},   
	{
		id: 2,
		name: 'Training 2',
		dueDate: new Date(),
		timeToComplete: 4,
		progress: 50,
		description: 'This is another example training',
		status: TrainingStatus.inProgress
	},   
	{
		id: 3,
		name: 'Training 3',
		dueDate: new Date(),
		timeToComplete: 1,
		progress: 0,
		description: 'Sometimes I like to sleep in late. It is also really awesome, although its like totally too long and is overflowing',
		status: TrainingStatus.notStarted
	},   
	{
		id: 4,
		name: 'Training 4',
		dueDate: new Date(),
		timeToComplete: 2.5,
		progress: 100,
		description: 'This is another example training. Yeah',
		status: TrainingStatus.complete
	},   
]