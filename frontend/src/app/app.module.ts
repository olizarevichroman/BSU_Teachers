import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';

import {AppComponent} from './app.component';
import {FacultiesComponent} from './faculties/faculties.component';
import {HttpService} from "./services/http/http.service.api";
import {HttpServiceImpl} from "./services/http/http.service";
import {HttpClientModule} from "@angular/common/http";
import {RouteHelperService} from "./services/route_helper/route-helper.service.api";
import {RouteHelperServiceImpl} from "./services/route_helper/route-helper.service";

@NgModule({
  declarations: [
    AppComponent,
    FacultiesComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [
    {
      provide: HttpServiceImpl, useClass: HttpService
    },
    {
      provide: RouteHelperServiceImpl, useClass: RouteHelperService
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
}
