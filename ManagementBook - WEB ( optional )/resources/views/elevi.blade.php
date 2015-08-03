@extends('layout')
@section('content')
<div class="container-fluid">
  <!-- Navbarul din dreapta -->
  <div class="row">
    <div class="col-sm-3 col-md-2 sidebar">
      <ul class="nav nav-sidebar">
        <li class="active"><a href="/elevi">Elevi</a></li>
        <li><a href="/profesori">Profesori</a></li>
      </ul>
      <ul class="nav nav-sidebar">
        <li><a href="/orarelevi">Orar elevi</a></li>
        <li><a href="/orarprof">Orar profesori</a></li>
      </ul>
      <ul class="nav nav-sidebar">
        <li><a href="/situatiescolara">Situatie scolara elevi</a></li>
      </ul>
    </div>

  <!--Contentul principal -->
  <div class="col-sm-9 col-sm-offset-3 col-md-10 col-md-offset-2 main">
    <div class="jumbotron">
      <div class="row" style="margin-bottom:10px;">
        <div class="col-lg-4">
          <div class="input-group">
            <form  action="/elevi" method="get">
              <input type="text" class="form-control" placeholder="Nume" name="nume">
              <span class="input-group-btn">
                <button class="btn btn-default" type="submit"><span class="glyphicon glyphicon-search"></span></button>
              </span>
            </form>
          </div>
        </div>
        <div class="col-lg-4">
          <div class="input-group">
            <form  action="/elevi" method="get">
              <input type="text" class="form-control" placeholder="Prenume" name="prenume">
              <span class="input-group-btn">
                <button class="btn btn-default" type="submit"><span class="glyphicon glyphicon-search"></span></button>
              </span>
            </form>
          </div>
        </div>
        <div class="col-lg-4">
          <div class="input-group">
            <form  action="/elevi" method="get">
             <input type="text" class="form-control" placeholder="Materie" name="materie">
              <span class="input-group-btn">
                <button class="btn btn-default" type="submit"><span class="glyphicon glyphicon-search"></span></button>
              </span>
            </form>
          </div>
        </div>     
    </div>
  

  <!-- Table -->
  <div class="table-responsive">
            <table class="table table-striped">
              <thead>
                <tr>
                  <th>#</th>
                  <th>Nume</th>
                  <th>Prenume</th>
                  <th>Clasa</th>
                  <th>Data nasterii</th>
              	  <th>Adresa</th>
              	  <th>Numar tel:</th>
                </tr>
              </thead>
              <tbody>
              @foreach($student as $students)
                <tr>
                  <td>{{ $students->ID }} </td>
                  <td>{{ $students->Nume }}</td>
                  <td>{{ $students->Prenume }}</td>
                  <td>{{ $students->Clasa}}</td>
                  <td> {{$students=['Data nasterii'] }}</td>
                  <td> {{ $students->Adresa}}</td>
                  <td>{{ $students=['Numar tel:'] }}</td>
                </tr>
               @endforeach
              </tbody>
            </table>
  </div>
</div>
</div>
</div>
@stop