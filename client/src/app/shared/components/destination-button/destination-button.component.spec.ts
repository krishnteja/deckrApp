import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DestinationButtonComponent } from './destination-button.component';

describe('DestinationButtonComponent', () => {
  let component: DestinationButtonComponent;
  let fixture: ComponentFixture<DestinationButtonComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DestinationButtonComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DestinationButtonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
