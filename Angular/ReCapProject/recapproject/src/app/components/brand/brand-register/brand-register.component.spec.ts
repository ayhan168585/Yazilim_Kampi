import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BrandRegisterComponent } from './brand-register.component';

describe('BrandRegisterComponent', () => {
  let component: BrandRegisterComponent;
  let fixture: ComponentFixture<BrandRegisterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BrandRegisterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BrandRegisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
