import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TrainingComponent } from './components/training/training.component';
import { AuthUserGuard } from '../auth/auth-user.guard';

const trainingRoutes: Routes = [
  { path: 'training',  component: TrainingComponent, canActivate: [AuthUserGuard]}
];

@NgModule({
  imports: [
    RouterModule.forChild(trainingRoutes)
  ],
  exports: [
    RouterModule
  ], 
  providers: [
	  AuthUserGuard
  ]
})
export class TrainingRoutingModule { }