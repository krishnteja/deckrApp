import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AllUsersProgressComponent } from './all-users-progress.component';

describe('AllUsersProgressComponent', () => {
  let component: AllUsersProgressComponent;
  let fixture: ComponentFixture<AllUsersProgressComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AllUsersProgressComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AllUsersProgressComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
