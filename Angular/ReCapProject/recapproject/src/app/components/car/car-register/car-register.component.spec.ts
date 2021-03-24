import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarRegisterComponent } from './car-register.component';

describe('CarRegisterComponent', () => {
  let component: CarRegisterComponent;
  let fixture: ComponentFixture<CarRegisterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CarRegisterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CarRegisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
