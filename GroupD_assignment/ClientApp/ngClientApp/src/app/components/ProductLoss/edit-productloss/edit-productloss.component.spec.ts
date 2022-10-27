import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditProductlossComponent } from './edit-productloss.component';

describe('EditProductlossComponent', () => {
  let component: EditProductlossComponent;
  let fixture: ComponentFixture<EditProductlossComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditProductlossComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditProductlossComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
