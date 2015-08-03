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
   
      
        

  

  <!-- Table -->
   <div class="table-responsive">
            <table class="table table-striped">
              <thead>
                <tr>
                  <th>#</th>
                  <th>Nume</th>
                  <th>Prenume</th>
                  <th>Clasa</th>
                  <th>Diriginte</th>
                  <th>Materie 1</th>
                  <th>Materie 2</th>
                  <th>Materie 3</th>
                  <th>Materie 4</th>
                  <th>Materie 5</th>
                  <th>Materie 6</th>
                  <th>Materie 7</th>
                  <th>Materie 8</th>
                  <th>Materie 9</th>
                  <th>Materie 10</th>
                  <th>Materie 11</th>
                  <th>Materie 12</th>
                  <th>Materie 13</th>
                  <th>Materie 14</th>
                  <th>Materie 15</th>
                  <th>Materie 16</th>
                  <th>Materie 17</th>
                  <th>Materie 18</th>
                  <th>Materie 19</th>
                  <th>Materie 20</th>
                  <th>Materie 21</th>
                  <th>Materie 22</th>
                  <th>Materie 23</th>
                  <th>Materie 24</th>
                  <th>Materie 25</th>
                  <th>Semestrul 1</th>
                  <th>Semestrul 2</th>
                  <th>Media Anuala</th>
                </tr>
              </thead>
              <tbody>
              @foreach($situatie as $situatii)
                <tr>
                  <td>{{ $situatii->ID }} </td>
                  <td>{{ $situatii->Nume }}</td>
                  <td>{{ $situatii->Prenume }}</td>
                  <td>{{ $situatii->Clasa }}</td>
                  <td> {{ $situatii->Diriginte }}</td>
                  <td>{{ $situatii->m1 }} : {{ $situatii->n1 }}</td>
                  <td>{{ $situatii->m2 }} : {{ $situatii->n2 }}</td>
                  <td>{{ $situatii->m3 }} : {{ $situatii->n3 }}</td>
                  <td>{{ $situatii->m4 }} : {{ $situatii->n4 }}</td>
                  <td>{{ $situatii->m5 }} : {{ $situatii->n5 }}</td>
                  <td>{{ $situatii->m6 }} : {{ $situatii->n6 }}</td>
                  <td>{{ $situatii->m7 }} : {{ $situatii->n7 }}</td>
                  <td>{{ $situatii->m8 }} : {{ $situatii->n7 }}</td>
                  <td>{{ $situatii->m9 }} : {{ $situatii->n9 }}</td>
                  <td>{{ $situatii->m10 }} : {{ $situatii->n10 }}</td>
                  <td>{{ $situatii->m11 }} : {{ $situatii->n11 }}</td>
                  <td>{{ $situatii->m12 }} : {{ $situatii->n12 }}</td>
                  <td>{{ $situatii->m13 }} : {{ $situatii->n13 }}</td>
                  <td>{{ $situatii->m14 }} : {{ $situatii->n14 }}</td>
                  <td>{{ $situatii->m15 }} : {{ $situatii->n15 }}</td>
                  <td>{{ $situatii->m16 }} : {{ $situatii->n16 }}</td>
                  <td>{{ $situatii->m17 }} : {{ $situatii->n17 }}</td>
                  <td>{{ $situatii->m18 }} : {{ $situatii->n18 }}</td>
                  <td>{{ $situatii->m19 }} : {{ $situatii->n19 }}</td>
                  <td>{{ $situatii->m20 }} : {{ $situatii->n20 }}</td>
                  <td>{{ $situatii->m21 }} : {{ $situatii->n21 }}</td>
                  <td>{{ $situatii->m22 }} : {{ $situatii->n22 }}</td>
                  <td>{{ $situatii->m23 }} : {{ $situatii->n23 }}</td>
                  <td>{{ $situatii->m24 }} : {{ $situatii->n24 }}</td>
                  <td>{{ $situatii->m25 }} : {{ $situatii->n25 }}</td>
                  <td>{{ $situatii->Semestrul_1 }}</td>
                  <td>{{ $situatii->Semestrul_2 }}</td>
                  <td>{{ $situatii->Media_Anuala}}</td>
                </tr>
               @endforeach
              </tbody>
            </table>
</div>


</div>
  </div>
      </div>
@stop