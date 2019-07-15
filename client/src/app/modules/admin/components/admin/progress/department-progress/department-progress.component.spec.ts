import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DepartmentProgressComponent } from './department-progress.component';

describe('DepartmentProgressComponent', () => {
  let component: DepartmentProgressComponent;
  let fixture: ComponentFixture<DepartmentProgressComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DepartmentProgressComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DepartmentProgressComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
