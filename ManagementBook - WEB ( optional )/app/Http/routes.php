<?php

/*
|--------------------------------------------------------------------------
| Application Routes
|--------------------------------------------------------------------------
|
| Here is where you can register all of the routes for an application.
| It's a breeze. Simply tell Laravel the URIs it should respond to
| and give it the controller to call when that URI is requested.
|
*/
Route::get('/', 'PagesController@index');

Route::controllers([
	'auth' => 'Auth\AuthController',
	'register' => 'Auth\AuthController']);
// Toate aflate sub acest grup necesita logare pentru a fii accesate
Route::group(['middleware' => 'auth'],function(){
Route::get('dashboard', 'PagesController@dashboard');
Route::get('orarprof','PagesController@orarprof');
Route::get('orarelevi', 'PagesController@orarelevi');
Route::get('elevi','PagesController@elevi');
Route::get('profesori','PagesController@profesori');
Route::get('situatiescolara', 'PagesController@situatie');
});
