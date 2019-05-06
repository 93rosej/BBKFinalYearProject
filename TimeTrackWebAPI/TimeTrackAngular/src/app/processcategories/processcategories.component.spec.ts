import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProcesscategoriesComponent } from './processcategories.component';

describe('ProcesscategoriesComponent', () => {
  let component: ProcesscategoriesComponent;
  let fixture: ComponentFixture<ProcesscategoriesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProcesscategoriesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProcesscategoriesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
