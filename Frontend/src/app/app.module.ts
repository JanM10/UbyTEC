import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { Routes, RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { AddempleadoComponent } from './addempleado/addempleado.component';
import { UpdateempleadoComponent } from './updateempleado/updateempleado.component';
import { DeleteempleadoComponent } from './deleteempleado/deleteempleado.component';
import { ListempleadoComponent } from './listempleado/listempleado.component';
import { AddadminComponent } from './addadmin/addadmin.component';
import { UpdateadminComponent } from './updateadmin/updateadmin.component';
import { DeleteadminComponent } from './deleteadmin/deleteadmin.component';
import { ListadminComponent } from './listadmin/listadmin.component';
import { AddafiliadoComponent } from './addafiliado/addafiliado.component';
import { UpdateafiliadoComponent } from './updateafiliado/updateafiliado.component';
import { DeleteafiliadoComponent } from './deleteafiliado/deleteafiliado.component';
import { ListafiliadoComponent } from './listafiliado/listafiliado.component';
import { AddcomercioComponent } from './addcomercio/addcomercio.component';
import { UpdatecomercioComponent } from './updatecomercio/updatecomercio.component';
import { DeletecomercioComponent } from './deletecomercio/deletecomercio.component';
import { ListcomercioComponent } from './listcomercio/listcomercio.component';
import { AddproductComponent } from './addproduct/addproduct.component';
import { UpdateproductComponent } from './updateproduct/updateproduct.component';
import { DeleteproductComponent } from './deleteproduct/deleteproduct.component';
import { ListproductComponent } from './listproduct/listproduct.component';
import { AddrepartidorComponent } from './addrepartidor/addrepartidor.component';
import { UpdaterepartidorComponent } from './updaterepartidor/updaterepartidor.component';
import { DeleterepartidorComponent } from './deleterepartidor/deleterepartidor.component';
import { ListrepartidorComponent } from './listrepartidor/listrepartidor.component';
import { AddclienteComponent } from './addcliente/addcliente.component';
import { UpdateclienteComponent } from './updatecliente/updatecliente.component';
import { DeleteclienteComponent } from './deletecliente/deletecliente.component';
import { ListclienteComponent } from './listcliente/listcliente.component';
import { AsignacionComponent } from './asignacion/asignacion.component';
import { ListpedidosComponent } from './listpedidos/listpedidos.component';
import { MispedidosComponent } from './mispedidos/mispedidos.component';
import { CarritoComponent } from './carrito/carrito.component';
import { InicioSesionComponent } from './inicio-sesion/inicio-sesion.component';
import { FormsModule } from '@angular/forms';
import { SharedService } from './shared.service';
import { AuthenticationService } from './authentication.service';
import { PagarComponent } from './pagar/pagar.component';
import { RConsolidadoVentasComponent } from './r-consolidado-ventas/r-consolidado-ventas.component';
import { RVentasPorClienteComponent } from './r-ventas-por-cliente/r-ventas-por-cliente.component';

@NgModule({
  declarations: [
    AppComponent,
    AddempleadoComponent,
    UpdateempleadoComponent,
    DeleteempleadoComponent,
    ListempleadoComponent,
    AddadminComponent,
    UpdateadminComponent,
    DeleteadminComponent,
    ListadminComponent,
    AddafiliadoComponent,
    UpdateafiliadoComponent,
    DeleteafiliadoComponent,
    ListafiliadoComponent,
    AddcomercioComponent,
    UpdatecomercioComponent,
    DeletecomercioComponent,
    ListcomercioComponent,
    AddproductComponent,
    UpdateproductComponent,
    DeleteproductComponent,
    ListproductComponent,
    AddrepartidorComponent,
    UpdaterepartidorComponent,
    DeleterepartidorComponent,
    ListrepartidorComponent,
    AddclienteComponent,
    UpdateclienteComponent,
    DeleteclienteComponent,
    ListclienteComponent,
    AsignacionComponent,
    ListpedidosComponent,
    MispedidosComponent,
    CarritoComponent,
    InicioSesionComponent,
    PagarComponent,
    RConsolidadoVentasComponent,
    RVentasPorClienteComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      /**rutas para mostrar los diferentes componentes de la aplicacion */
      {path: 'addEmpleado', component: AddempleadoComponent},
      {path: 'elimEmpleado', component: DeleteempleadoComponent},/////
      {path: 'actEmpleado', component: UpdateempleadoComponent},
      {path: 'tablaEmpleado', component: ListempleadoComponent},

      {path: 'addAdministrador', component: AddadminComponent},
      {path: 'elimAdministrador', component: DeleteadminComponent},/////
      {path: 'actAdministrador', component: UpdateadminComponent},
      {path: 'tablaAdministrador', component: ListadminComponent},

      {path: 'addAfi', component: AddafiliadoComponent},
      {path: 'elimAfi', component: DeleteafiliadoComponent},/////
      {path: 'actAfi', component: UpdateafiliadoComponent},
      {path: 'tablaAfi', component: ListafiliadoComponent},

      {path: 'addCliente', component: AddclienteComponent},
      {path: 'elimCliente', component: DeleteclienteComponent},///////////
      {path: 'actCliente', component: UpdateclienteComponent},
      {path: 'tablaCliente', component: ListclienteComponent},

      {path: 'addProd', component: AddproductComponent},
      {path: 'elimProd', component: DeleteproductComponent},//////
      {path: 'actProd', component: UpdateproductComponent},
      {path: 'tablaProd', component: ListproductComponent},

      {path: 'addRep', component: AddrepartidorComponent},
      {path: 'elimRep', component: DeleterepartidorComponent},////////
      {path: 'actRep', component: UpdaterepartidorComponent},
      {path: 'tablaRep', component: ListrepartidorComponent},

      {path: 'addCom', component: AddcomercioComponent},
      {path: 'elimCom', component: DeletecomercioComponent},///////
      {path: 'actCom', component: UpdatecomercioComponent},
      {path: 'tablaCom', component: ListcomercioComponent},

      {path: 'asigPedido', component: AsignacionComponent},
      {path: 'tablaPedidos', component: ListpedidosComponent},

      {path: 'misPedidos', component: MispedidosComponent},
      {path: 'carrito', component: CarritoComponent},
      {path: 'inicio', component: InicioSesionComponent},

      {path: 'rVentas', component: RVentasPorClienteComponent},
      {path: 'pagar', component: PagarComponent},
      {path: 'rConsolidado', component: RConsolidadoVentasComponent},

      /**rutas para redireccion a la pagina principal o a la pagina 404 de error */
      {path: '', redirectTo: '/empleados', pathMatch: 'full'},
      //{path: '**', component: PageNotFoundComponent}
    ]),
  ],
  providers: [SharedService,AuthenticationService],
  bootstrap: [AppComponent]
})
export class AppModule { }
