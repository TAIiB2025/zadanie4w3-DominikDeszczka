import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Film } from '../models/film';
import { FilmBody } from '../models/film-body';

@Injectable({
  providedIn: 'root'
})
export class ListaService {
  private baseUrl = 'http://localhost:5002/api/filmy';

  constructor(private httpClient: HttpClient) { }

  get(): Observable<Film[]> {
    return this.httpClient.get<Film[]>(this.baseUrl);
  }

  getByID(id: number): Observable<Film> {
    return this.httpClient.get<Film>(`${this.baseUrl}/${id}`);
  }

  delete(id: number): Observable<void> {
    return this.httpClient.delete<void>(`${this.baseUrl}/${id}`);
  }

  put(id: number, body: FilmBody): Observable<void> {
    return this.httpClient.put<void>(`${this.baseUrl}/${id}`, body);
  }

  post(body: FilmBody): Observable<void> {
    return this.httpClient.post<void>(this.baseUrl, body);
  }
}
