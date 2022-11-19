import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteafiliadoComponent } from './deleteafiliado.component';

describe('DeleteafiliadoComponent', () => {
  let component: DeleteafiliadoComponent;
  let fixture: ComponentFixture<DeleteafiliadoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DeleteafiliadoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DeleteafiliadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
