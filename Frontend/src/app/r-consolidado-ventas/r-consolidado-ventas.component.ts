import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-r-consolidado-ventas',
  templateUrl: './r-consolidado-ventas.component.html',
  styleUrls: ['./r-consolidado-ventas.component.css']
})
export class RConsolidadoVentasComponent implements OnInit {

  constructor(private service:SharedService,private formBuilder:FormBuilder) { 
    this.checkoutForm = this.formBuilder.group({
      nombre: '',
      apellido1: '',
      apellido2: '',
      cedula: '',
      provincia: '',
      canton: '',
      distrito: '',
      tel1: '',
      tel2: '',
      rol: '',
      usuario: '',
      pass: ''
    });
  }

  //Variables
  EmpleadoList : any = []; 
  checkoutForm: any;

  ngOnInit(): void {
  }

  // agregar metodo para rellenar la tabla

}
