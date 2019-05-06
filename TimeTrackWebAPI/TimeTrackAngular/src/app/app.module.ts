import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { UsersComponent } from './users/users.component';
import { UserComponent } from './users/user/user.component';
import { UserListComponent } from './users/user-list/user-list.component';
import { ActivitiesComponent } from './activities/activities.component';
import { ProcessesComponent } from './processes/processes.component';
import { ProcesswindowsComponent } from './processwindows/processwindows.component';
import { DepartmentsComponent } from './departments/departments.component';
import { ProcesscategoriesComponent } from './processcategories/processcategories.component';
import { ProcesscategoryComponent } from './processcategories/processcategory/processcategory.component';
import { ProcesscategoryListComponent } from './processcategories/processcategory-list/processcategory-list.component';
import { ProcessComponent } from './processes/process/process.component';
import { ProcessListComponent } from './processes/process-list/process-list.component';
import { ActivityComponent } from './activities/activity/activity.component';
import { ActivityListComponent } from './activities/activity-list/activity-list.component';

import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    UsersComponent,
    UserComponent,
    UserListComponent,
    ActivitiesComponent,
    ProcessesComponent,
    ProcesswindowsComponent,
    DepartmentsComponent,
    ProcesscategoriesComponent,
    ProcesscategoryComponent,
    ProcesscategoryListComponent,
    ProcessComponent,
    ProcessListComponent,
    ActivityComponent,
    ActivityListComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
