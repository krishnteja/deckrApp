import { NgModule } from "@angular/core";
import { CommonModule } from '@angular/common';
import { SharedModule } from 'src/app/shared/modules/shared.module';
import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './components/home/home.component';
import { ContractsSummaryComponent } from './components/home/contracts-summary/contracts-summary.component';
import { TrainingsSummaryComponent } from './components/home/trainings-summary/trainings-summary.component';
import { SecurityGroupsSummaryComponent } from './components/home/security-groups-summary/security-groups-summary.component';

@NgModule({
	imports: [
		CommonModule,
		SharedModule,
		HomeRoutingModule
	],
	declarations: [
		HomeComponent,
		ContractsSummaryComponent,
		TrainingsSummaryComponent,
		SecurityGroupsSummaryComponent
	]
})
export class HomeModule {

}
