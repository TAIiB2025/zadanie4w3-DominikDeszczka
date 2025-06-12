import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { Observable } from 'rxjs';
import { Film } from '../models/film';
import { ListaService } from './lista.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  dane$!: Observable<Film[]>;

  constructor(private listaService: ListaService) { }

  ngOnInit(): void {
    this.dane$ = this.listaService.get();
  }
}

