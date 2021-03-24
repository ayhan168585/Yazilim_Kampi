import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ColorRegisterComponent } from './color-register.component';

describe('ColorRegisterComponent', () => {
  let component: ColorRegisterComponent;
  let fixture: ComponentFixture<ColorRegisterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ColorRegisterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ColorRegisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
