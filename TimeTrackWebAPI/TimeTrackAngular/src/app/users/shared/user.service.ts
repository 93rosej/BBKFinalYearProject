import { Injectable } from '@angular/core';
import { Response, Headers, RequestOptions, RequestMethod } from '@angular/http';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { map } from "rxjs/operators";
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';
import {User} from './user.model';

@Injectable()
export class UserService {
  selectedUser: User;
  userList: User[];
  constructor(private http: HttpClient) { }

  postUser(user: User) {
    const body = JSON.stringify(user);
    const headerOptions = new Headers({'Content-Type': 'application/json'});
    const requestOptions = new RequestOptions({method : RequestMethod.Post, headers : headerOptions});
    return this.http.post('http://localhost:28750/api/User', body, requestOptions).map(x => x.json());
  }

  putUser(id, user) {
    const body = JSON.stringify(emp);
    const headerOptions = new Headers({ 'Content-Type': 'application/json' });
    const requestOptions = new RequestOptions({ method: RequestMethod.Put, headers: headerOptions });
    return this.http.put('http://localhost:28750/api/User/' + id,
      body,
      requestOptions).map(res => res.json());
  }

  getUserList() {
    this.http.get('http://localhost:28750/api/User')
    .map((data : Response) =>{
      return data.json() as User[];
    }).toPromise().then(x => {
      this.userList = x;
    })
  }

  deleteUser(id: number) {
    return this.http.delete('http://localhost:28750/api/User/' + id).map(res => res.json());
  }
}
