import { Routes } from '@angular/router';

export const AUTH_ROUTES: Routes = [
  {
    path: '',
    redirectTo: 'login',
    pathMatch: 'full',
  },
  {
    path: 'login',
    loadComponent: () => import('./views/login/login.component'),
    title: 'Learn-teach | login',
  },
  {
    path: 'register',
    loadComponent: () => import('./views/register/register.component'),
    title: 'Learn-teach | register',
  },
  {
    path: '**',
    redirectTo: 'login',
    pathMatch: 'full',
  },
];

export default AUTH_ROUTES;
