import {HttpService} from "./http.service.api";
import {Observable} from "rxjs/internal/Observable";
import {HttpErrorResponse} from "@angular/common/http";
import {RouteHelperService} from "../route_helper/route-helper.service.api";
import {throwError} from "rxjs/internal/observable/throwError";
import {Injectable} from "@angular/core";
import {Http} from "@angular/http";
import {catchError} from "rxjs/operators";

@Injectable()
export class HttpServiceImpl implements HttpService {

  constructor(private http: Http,
              private routeHelper: RouteHelperService) {
  }

  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      console.error("ErrorEvent error", error.error.message);
    } else {
      console.error("Backend Error with status ${error.status} and body ${error.error}");
    }

    return throwError("Something was wrong!!!");
  }

  get(route: string): Observable<any> {
    return this.http.get(this.routeHelper.resolveRoute(route))
      .pipe(catchError(this.handleError));
  }

  post(route: string, body: any): Observable<any> {
    return this.http.post(this.routeHelper.resolveRoute(route), body)
      .pipe(catchError(this.handleError));
  }

}
