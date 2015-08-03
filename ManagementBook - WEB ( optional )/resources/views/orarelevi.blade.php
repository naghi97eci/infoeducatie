@extends('layout')
@section('content')
 <div class="container-fluid">
      <div class="row">
        <div class="col-sm-3 col-md-2 sidebar">
          <ul class="nav nav-sidebar">
            <li ><a href="/elevi">Elevi</a></li>
            <li ><a href="/profesori">Profesori</a></li>
          </ul>
          <ul class="nav nav-sidebar">
            <li class="active" ><a href="/orarelevi">Orar elevi</a></li>
            <li><a href="/orarprof">Orar profesori</a></li>
          </ul>
          <ul class="nav nav-sidebar">
            <li><a href="/situatiescolara">Situatie scolara elevi</a></li>
         
          </ul>
        </div>
      <div class="col-sm-9 col-sm-offset-3 col-md-10 col-md-offset-2 main">
     
      <div class="jumbotron">
      <div class="row" style="margin-bottom:10px;">
      <div class="col-lg-4">
        <div class="input-group">
          <form  action="/orarelevi" method="get">
            <input type="text" class="form-control" placeholder="Clasa" name="clasa">
            <span class="input-group-btn">
              <button class="btn btn-default" type="submit"><span class="glyphicon glyphicon-search"></span></button>
            </span>
          </form>
        </div>
      </div>
      <div class="col-lg-4">
        <div class="input-group">
          <form  action="/orarelevi" method="get">
            <input type="text" class="form-control" placeholder="Diriginte" name="diriginte">
            <span class="input-group-btn">
              <button class="btn btn-default" type="submit"><span class="glyphicon glyphicon-search"></span></button>
            </span>
          </form>
        </div>
      </div>
      <div class="col-lg-4">
        <div class="input-group">
          <form  action="/orarelevi" method="get">
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
                  <th>Clasa</th>
                  <th>Diriginte</th>
                  <th>Ora</th>
                  <th>Luni</th>
              	  <th>Marti</th>
              	  <th>Miercuri</th>
                  <th>Joi</th>
                  <th>Vineri</th>
                </tr>
              </thead>
              <tbody>
              @foreach($orarstudent as $orarstudenti)
                <tr>
                  <td>{{ $orarstudenti->ID }} </td>
                  <td>{{ $orarstudenti->Clasa }}</td>
                  <td>{{ $orarstudenti->Diriginte }}</td>
                  <td>{{ $orarstudenti->Ora }}</td>
                  <td> {{ $orarstudenti->Luni }}</td>
                  <td>{{ $orarstudenti->Marti }}</td>
                  <td>{{ $orarstudenti->Miercuri }}</td>
                  <td>{{ $orarstudenti->Joi }}</td>
                  <td>{{ $orarstudenti->Vineri }}</td>
                </tr>
               @endforeach
              </tbody>
            </table>
</div>


</div>
  </div>
      </div>
@stop