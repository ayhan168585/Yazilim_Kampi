import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarImageRegisterComponent } from './car-image-register.component';

describe('CarImageRegisterComponent', () => {
  let component: CarImageRegisterComponent;
  let fixture: ComponentFixture<CarImageRegisterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CarImageRegisterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CarImageRegisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
