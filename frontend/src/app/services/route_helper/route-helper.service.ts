import {RouteHelperService} from "./route-helper.service.api";
import {Route} from "../../models/route.model";
import {Inject} from "@angular/compiler/src/core";
import {ROUTES} from "../../mocks/mocks.routes";
import {Injectable} from "@angular/core";

@Injectable()
export class RouteHelperServiceImpl implements RouteHelperService{

  private routes: Route[];

  constructor(){
    this.routes = ROUTES;
  }

  resolveRoute(route: string): string {
    return this.routes.find((object: Route) => {
      return route === object.alias;
    }).route;
  }

}
