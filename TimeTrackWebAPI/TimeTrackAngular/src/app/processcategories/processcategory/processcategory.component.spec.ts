import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProcesscategoryComponent } from './processcategory.component';

describe('ProcesscategoryComponent', () => {
  let component: ProcesscategoryComponent;
  let fixture: ComponentFixture<ProcesscategoryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProcesscategoryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProcesscategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
