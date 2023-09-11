import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoogleSignInBtnComponent } from './google-sign-in-btn.component';

describe('GoogleSignInBtnComponent', () => {
  let component: GoogleSignInBtnComponent;
  let fixture: ComponentFixture<GoogleSignInBtnComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoogleSignInBtnComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GoogleSignInBtnComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
