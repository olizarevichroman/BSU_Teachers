import {Observable} from "rxjs/internal/Observable";

export abstract class HttpService{

  abstract get(route: string): Observable<any>;

  abstract post(route: string, body: any): Observable<any>;

}
