import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MaterialModule } from './material.module';
import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { FooterComponent } from '../components/footer/footer.component';
import { HeaderComponent } from '../components/header/header.component';
import { SidenavListComponent } from '../components/sidenav-list/sidenav-list.component';
import { CommonModule } from '@angular/common';
import { DestinationButtonComponent } from '../components/destination-button/destination-button.component';
import { ProgressIndicatorComponent } from '../components/progress-indicator/progress-indicator.component';
import { NgxChartsModule } from '@swimlane/ngx-charts';

@NgModule({
  imports: [
    FormsModule,
    ReactiveFormsModule,
    MaterialModule,
    RouterModule,
	CommonModule,
	NgxChartsModule
  ],
  declarations: [
    HeaderComponent,
    FooterComponent,
	SidenavListComponent,
	DestinationButtonComponent,
	ProgressIndicatorComponent
  ],
  providers: [],
  exports: [
    FormsModule,
    ReactiveFormsModule,
    MaterialModule,
    RouterModule,
    HeaderComponent,
    FooterComponent,
    SidenavListComponent ,
	CommonModule,
	DestinationButtonComponent,
	ProgressIndicatorComponent
  ]
})
export class SharedModule {}