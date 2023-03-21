import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'envirement';


@Injectable({
  providedIn: 'root'
})

export class HttpService {

  constructor(private http: HttpClient) { }
  // add baseUrl to url
  private getFullUrl(url: string) {
    return environment.apiUrl + url;
  }


  // get request
  get(url: string) {
    return this.http.get(this.getFullUrl(url));
  }

  // post request
  post(url: string, body: any) {
    return this.http.post(this.getFullUrl(url), body);
  }

  // put request
  put(url: string, body: any) {
    return this.http.put(this.getFullUrl(url), body);
  }

  // delete request
  delete(url: string) {
    return this.http.delete(this.getFullUrl(url));
  }

}
