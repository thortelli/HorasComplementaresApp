import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
    { path: '', redirectTo: '/app/home', pathMatch: 'full' },
    {
        path: 'introduction',
        loadChildren: 'introduction/introduction.module#IntroductionModule', // Lazy load account module
        data: { preload: true }
    },
    {
        path: 'app',
        loadChildren: 'app/app.module#AppModule', // Lazy load account module
        data: { preload: true }
    }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
    providers: []
})
export class RootRoutingModule { }
