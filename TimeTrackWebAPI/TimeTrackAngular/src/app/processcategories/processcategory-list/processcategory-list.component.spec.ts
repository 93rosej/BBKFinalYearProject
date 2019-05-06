import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProcesscategoryListComponent } from './processcategory-list.component';

describe('ProcesscategoryListComponent', () => {
  let component: ProcesscategoryListComponent;
  let fixture: ComponentFixture<ProcesscategoryListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProcesscategoryListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProcesscategoryListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
