import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { AuthUserGuard } from '../auth/auth-user.guard';

const homeRoutes: Routes = [
	{ path: 'home',  component: HomeComponent, canActivate: [AuthUserGuard]}
];

@NgModule({
  imports: [
    RouterModule.forChild(homeRoutes)
  ],
  exports: [
    RouterModule
  ], 
  providers: [
	  AuthUserGuard
  ]
})
export class HomeRoutingModule { }