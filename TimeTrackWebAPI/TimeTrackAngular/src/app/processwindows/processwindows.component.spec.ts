import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProcesswindowsComponent } from './processwindows.component';

describe('ProcesswindowsComponent', () => {
  let component: ProcesswindowsComponent;
  let fixture: ComponentFixture<ProcesswindowsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProcesswindowsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProcesswindowsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
