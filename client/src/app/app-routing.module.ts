import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './modules/auth/components/login/login.component';
import { RegistrationComponent } from './modules/auth/components/registration/registration.component';
import { AuthAdminGuard } from './modules/auth/auth-admin.guard';
import { AdminComponent } from './modules/admin/components/admin/admin.component';
import { TrainingComponent } from './modules/training/components/training/training.component';
import { AuthUserGuard } from './modules/auth/auth-user.guard';

const routes: Routes = [
	{ path: '', redirectTo: '/login', pathMatch: 'full' },
	{ path: 'register', component: RegistrationComponent },
	{ path: 'login', component: LoginComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }