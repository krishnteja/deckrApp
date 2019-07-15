import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContractsComponent } from './components/contracts/contracts.component';
import { AuthUserGuard } from '../auth/auth-user.guard';


const contractsRoutes: Routes = [
	{ path: 'contracts',  component: ContractsComponent, canActivate: [AuthUserGuard]}
];

@NgModule({
  imports: [
    RouterModule.forChild(contractsRoutes)
  ],
  exports: [
    RouterModule
  ],
  providers: [
	  AuthUserGuard
  ]
})
export class ContractsRoutingModule { }