import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AsignmtsListComponent } from './asignmts-list.component';

describe('AsignmtsListComponent', () => {
  let component: AsignmtsListComponent;
  let fixture: ComponentFixture<AsignmtsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AsignmtsListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AsignmtsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
