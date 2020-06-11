# ContactsHolder
Manage Email Address and contacts
<fieldset>  
       <legend>  
          Send Email  
       </legend>  
       @using (Html.BeginForm())  
          {  
          @Html.ValidationSummary()  
          <form class="form-group">
         <label class="control-label">From: </label>  
          <p class="form-control">@Html.TextBoxFor(m=>m.From)</p>  
          <label class="control-label">To: </label>  
          <p class="form-control">@Html.TextBoxFor(m=>m.To)</p>  
          <label class="control-label">Subject: </label>  
          <p class="form-control">@Html.TextBoxFor(m=>m.Subject)</p>  
          <label class="control-label">Body: </label>  
          <p class="form-control">@Html.TextAreaFor(m=>m.Body)</p>  
       <input type ="submit" value ="Send" /> 
          </form>
          
       } </fieldset> 