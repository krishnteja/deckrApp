import { NgModule } from "@angular/core";
import { CommonModule } from '@angular/common';
import { SharedModule } from 'src/app/shared/modules/shared.module';
import { AdminComponent } from './components/admin/admin.component';
import { AdminRoutingModule } from './admin-routing.module';
import { UserViewsComponent } from './components/admin/user-views/user-views.component';
import { ProgressComponent } from './components/admin/progress/progress.component';
import { UserProgressComponent } from './components/admin/progress/user-progress/user-progress.component';
import { DepartmentProgressComponent } from './components/admin/progress/department-progress/department-progress.component';
import { AllUsersProgressComponent } from './components/admin/progress/all-users-progress/all-users-progress.component';

@NgModule({
	imports: [
		CommonModule,
		SharedModule,
		AdminRoutingModule
	],
	declarations: [AdminComponent, UserViewsComponent, ProgressComponent, UserProgressComponent, DepartmentProgressComponent, AllUsersProgressComponent],
	entryComponents: []

})
export class AdminModule {

}
