import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RentalRegisterComponent } from './rental-register.component';

describe('RentalRegisterComponent', () => {
  let component: RentalRegisterComponent;
  let fixture: ComponentFixture<RentalRegisterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RentalRegisterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RentalRegisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
