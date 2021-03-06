import {
  HttpClient,
  HttpEvent,
  HttpHandler,
  HttpInterceptor,
  HttpRequest
} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Person } from '../models/Person.Model';
import { Account } from '../models/Account.Model';
import { Transporter } from '../models/transporter.model';
import { CONFIGURATION } from '../shared/app.constants';
import { v4 as uuid } from 'uuid';

@Injectable()
export class HomeService {
  private personActionUrl: string;
  private accountActionUrl: string;

  constructor(private http: HttpClient) {
    this.personActionUrl = CONFIGURATION.baseUrls.api + 'person';
    this.accountActionUrl = CONFIGURATION.baseUrls.api + 'account';
  }
  public createPerson(person: string): Observable<string> {
    return this.http.post<string>(this.personActionUrl, person)
      .pipe(catchError(this.handleError));
  }
  public createAccount(account: string): Observable<string> {
    return this.http
      .post<string>(this.accountActionUrl, account)
      .pipe(catchError(this.handleError));
  }
  
  private handleError(error: Response) {
    console.log(error);
    return throwError(error || 'Server error');
  }
}

