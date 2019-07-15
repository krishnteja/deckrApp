import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SecurityGroupsComponent } from './components/security-groups/security-groups.component';
import { AuthUserGuard } from '../auth/auth-user.guard';


const securityGroupsRoutes: Routes = [
  { path: 'securitygroups',  component: SecurityGroupsComponent, canActivate: [AuthUserGuard]}
];

@NgModule({
  imports: [
    RouterModule.forChild(securityGroupsRoutes)
  ],
  exports: [
    RouterModule
  ], 
  providers: [
	  AuthUserGuard
  ]
})
export class SecurityGroupsRoutingModule { }